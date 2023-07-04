using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    // Play Manager
    // Game Mode
    // 1. Single        - Stage Clear
    //  - Difficulty / Property
    //  - Enemy in line
    //  - Enemy Start in Start Point
    //  - Enemy Minus Life in End Point
    // 2. Challenge     - Infinite Stage (Earning Points)
    //  - idle game
    // 3. Multi         - 4 Players in 4 Lines and Shared Life
    //  - Server
    //  - 4 Players in 1 Room
    //  - Matching system
    public class PlayManager
    {
        public enum Difficulty
        {

        }

        public enum Property
        {

        }

        private int UserHP;
        public int HP
        {
            get {return UserHP;}
            set {UserHP = value;}
        }
        // Random Select Tower using start point
        private int startPoint;
        public int Point
        {
            get {return startPoint;}
            set {startPoint = value;}
        }

        public void startGame(int _HP, int _startPoint)
        {
            UserHP = _HP;
            startPoint = _startPoint;
        }
    }
}
