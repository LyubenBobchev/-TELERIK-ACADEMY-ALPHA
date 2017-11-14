namespace ProjectBattleGround
{
    public struct CurrentUnitPossition
    {
        //constructors
        public CurrentUnitPossition(int verticalPossition, int horizontalPossition)
        {
            this.HorizontalPossition = horizontalPossition;
            this.VerticalPossition = verticalPossition;
        }

        //properties
        public int HorizontalPossition
        {
            get;
            private set;
        }

        public int VerticalPossition
        {
            get;
            private set;
        }

    }
}
