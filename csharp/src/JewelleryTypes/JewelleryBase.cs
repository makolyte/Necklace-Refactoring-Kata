﻿using NecklaceRefactoringKata.Enums;

namespace NecklaceRefactoringKata.JewelleryTypes
{
    public abstract record JewelleryBase(Jewel Stone)
    {
        public virtual bool IsRing() { return false; }
        public virtual bool IsSmall() { return false; }
        public virtual bool IsEarring() { return false; }
        public virtual bool IsNecklace() { return false; }
        public virtual bool IsLarge() { return false; }
    }
}