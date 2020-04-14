namespace GALoseRateVisualtisation
{
    /// <summary>
    /// Struct that holds info about game stage.
    /// </summary>
    public class StageInfo
    {
        /// <summary>
        /// Order of the stage.
        /// </summary>
        public int StageIndex { set; get; }

        /// <summary>
        /// How many players started playing this stage.
        /// </summary>
        /// 
        public int Started { set; get; }

        /// <summary>
        /// How many times players have won.
        /// </summary>
        public int Won { set; get; }

        /// <summary>
        /// How many times players almost won.
        /// </summary>
        public int AlmostWon { set; get; }

        /// <summary>
        /// Equality comparison of 2 stages.
        /// </summary>
        public override bool Equals(object obj)
        {
            var info = obj as StageInfo;
            return info != null &&
                   StageIndex == info.StageIndex &&
                   Started == info.Started &&
                   Won == info.Won &&
                   AlmostWon == info.AlmostWon;
        }

        /// <summary>
        /// Returns hash code of the stage object.
        /// </summary>
        public override int GetHashCode()
        {
            var hashCode = -1406906831;
            hashCode = hashCode * -1521134295 + StageIndex.GetHashCode();
            hashCode = hashCode * -1521134295 + Started.GetHashCode();
            hashCode = hashCode * -1521134295 + Won.GetHashCode();
            hashCode = hashCode * -1521134295 + AlmostWon.GetHashCode();
            return hashCode;
        }

        /// <summary>
        /// String representation of the game stage. 
        /// For debug purposes.
        /// </summary>
        public override string ToString()
        {
            return $"Stage {StageIndex}: won {Won}, almost won {AlmostWon} of {Started}";
        }
    }

}
