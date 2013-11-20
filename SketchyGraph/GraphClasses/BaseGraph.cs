﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace SketchyGraph
{
    public abstract class BaseGraph
    {
        public int maxRange;
        public int minRange = 0;
        public int maxDomain;
        public int minDomain = 0;
        public string type;
        public bool hasbeenmodified = false;
        public bool hasbeendrawn = false;

        public List<Element> elements = null;

        public void addElement(Element element)
        {
            elements.Add(element);
        }

        public abstract void CalculateBoundingBoxes(double threshold);
    }
}
