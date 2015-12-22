﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Puzzle.PuzzleCode.Calculators
{
    public class GameHValueCalulator : HValueCalculatorInterface
    {
        private const float Costfactor = 1.0f;

        public float Execute(NodeInterface goal, NodeInterface node)
        {
            float result = 0.0f;
            var currentNode = node as GameNode;
            var goalNode = goal as GameNode;

            for (int i = 0; i < 9; i++)
            {
                if (goalNode == null) continue;
                int currentNumber = goalNode.Tiles[i];
                int currentIndex = FindTileCurrentIndex(currentNumber, currentNode);

                result = GetDistanceToGoalTileForIndex(result, i, currentIndex);
            }

            return result;
        }


        private static float GetDistanceToGoalTileForIndex(float result, int i, int currentIndex)
        {
            if (currentIndex == i + 0)
                return result;

            if (currentIndex == i + 1 || currentIndex == i + 3)
                result += Costfactor;
            else if (currentIndex == i + 2 || currentIndex == i + 4 || currentIndex == i + 6)
                result += 2 * Costfactor;
            else if (currentIndex == i + 5 || currentIndex == i + 7)
                result += 3 * Costfactor;
            else if (currentIndex == i + 8)
                result += 4 * Costfactor;
            return result;
        }

        private static int FindTileCurrentIndex(int goalNumber, GameNode current)
        {
            for (int j = 0; j < 9; j++)
            {
                if (current.Tiles[j] == goalNumber)
                {
                    return j;
                }
            }

            return -1;
        }
    }
}
