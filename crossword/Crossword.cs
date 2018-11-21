﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crossword
{
    public enum GameDifficulty
    {
        Easy
        , Medium
        , Hard
    }


    class Crossword
    {
        private Block[][] blocks { get; set; }

        public Block[][] GetBlocks()
        {
            return blocks;
        }

        public void GenerateNewCrossword(GameDifficulty difficulty) {
            string[] crw =
                new string[] {
                      "#character##"
                    , "#a##########"
                    , "#t#f###f####"
                    , "#a#a###o####"
                    , "#l#k###r####"
                    , "#overwatch##"
                    , "#g#####n####"
                    , "##drastikon#"
                    , "#######t####"
                    , "#kafeeeeee##"
                };

            blocks = new Block[crw.Length][];

            for (int row=0; row<crw.Length; row++)
            {
                blocks[row] = new Block[crw[0].Length];
                for (int col=0; col<crw[0].Length; col++)
                {
                    char c = crw[row][col];

                    if (c == '#')
                    {
                        blocks[row][col] = new Block(BlockState.Black, ' ');
                    }
                    else
                    {
                        Random r = new Random();
                        if (r.Next() % 100 <= 10)
                        {
                            blocks[row][col] = new Block(BlockState.Confirmed, c);
                        }
                        else
                        {
                            blocks[row][col] = new Block(BlockState.Empty, ' ');
                        }
                    }

                }
            }
        }

        public Block[][] GetBlockStates() {
            return new Block[][] {
                new Block[] { new Block(0), new Block(1), new Block(1), new Block (0) }
                , new Block[] { new Block(0), new Block(1), new Block(1), new Block (0) }
                , new Block[] { new Block(0), new Block(1), new Block(1), new Block (0) }
                , new Block[] { new Block(0), new Block(1), new Block(1), new Block (0) }
                , new Block[] { new Block(0), new Block(1), new Block(1), new Block (0) }
                , new Block[] { new Block(0), new Block(1), new Block(1), new Block (0) }
                , new Block[] { new Block(0), new Block(1), new Block(1), new Block (0) }
                , new Block[] { new Block(0), new Block(1), new Block(1), new Block (0) }

            };
        }



    }
}
