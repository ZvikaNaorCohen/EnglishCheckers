﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B22_Ex05_Zvika_208494245_Omri_315873471
{
    public class UpgradedButton : Button
    {
        public Point m_PositionOnBoard{get;set;}

        public Point[,] m_PossibleEatingPoints;

        public bool m_CanEatUpRight = false;
        public bool m_CanEatDownRight = false;
        public bool m_CanEatUpLeft = false;
        public bool m_CanEatDownLeft = false;


        public UpgradedButton(Point i_PointOnBoard)
        {
            m_PositionOnBoard = i_PointOnBoard;
        }


    }
}
