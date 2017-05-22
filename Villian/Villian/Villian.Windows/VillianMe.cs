using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Villian
{
    class VillianMe
    {
        Char[] TextArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ' };

        //String[] NumberArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "21", "23", "24", "25", "26", "27", "28", "29", "30", "31"};


        String[] FirstNameArray ={"Red",
                                 "Dark",
                                 "Grey",
                                 "Tidal",
                                 "Tri",
                                 "Strike",
                                 "Poison",
                                 "Flare",
                                 "Blue",
                                 "Killer",
                                 "Black",
                                 "Infinity",
                                 "Star",
                                 "Pale",
                                 "Crazed",
                                 "Quake",
                                 "Feral",
                                 "Soric",
                                 "White",
                                 "Devil",
                                 "Green",
                                 "Silver",
                                 "Psion",
                                 "Artic",
                                 "Green",
                                 "Storm",
                                  " "};

        String[] MiddleNameArray ={"Warrior",
                                   "Doctor",
                                   "Tempter",
                                   "Shot",
                                   "Doom",
                                   "Sword",
                                   "Stalker",
                                   "Killer",
                                   "Slicer",
                                   "Thorn",
                                   "Fist",
                                   "Tyrant",
                                   "Lord",
                                   "Professor",
                                   "Dragon",
                                   "Whip",
                                   "Nymph",
                                   "Tiger",
                                   "Cyborg",
                                   "Wizard",
                                   "Light",
                                   "Brain",
                                   "One",
                                   "Beast",
                                   "Croc",
                                   "Born",
                                    " "};

        String[] SecondNameArray ={"the Trickster of Men",
                                "the Destroyer of Hope",
                                "the Terror of Europe",
                                "the Ruler Gothom",
                                "the Murderer of Women",
                                "the Richest of Freedom",
                                "the Monarch of the Ancient Ones",
                                "the Master of Death",
                                "the Enslaver of Humanity",
                                "the Horror of Time",
                                "the Mistake of Earth",
                                "the Mecenary of the States",
                                "the Keeper of the Future",
                                "the Rogue of Asia",
                                "the General of Mars",
                                "the Revieled of Knowledge",
                                "the Smiter of the Galaxy",
                                "the Eviscerater of the Stars",
                                "the Queller of the Living",
                                "the Abolisher of Law",
                                "the Sliencer of Metropolis",
                                "the Watcher of Asia",
                                "the Assassin of Faith",
                                "the Pestilence of Space",
                                "the Feared of Nature",
                                "the Demon of Lust",
                                " "};


        public String getFirstValue(char userVariable)
        {

            String temp1 = " ";
            //for loop where if user puts in charactor
            for (int i = 0; i < TextArray.Length; i++)
            {

                if (TextArray[i] == userVariable)
                {
                    temp1 = FirstNameArray[i].ToString();
                    return temp1;
                }
            }
            return temp1;
        }


        public String getSecondValue(char userVariable)
        {

            String temp2 = " ";

            for (int i = 0; i < TextArray.Length; i++)
            {
                if (TextArray[i] == userVariable)
                {
                    temp2 = MiddleNameArray[i].ToString();
                    return temp2;
                }

            }

            return temp2;
        }

        public String getThirdValue(char userVariable)
        {

            String temp3 = " ";

            for (int i = 0; i < TextArray.Length; i++)
            {
                if (TextArray[i] == userVariable)
                {
                    temp3 = SecondNameArray[i].ToString();
                    return temp3;
                }

            }

            return temp3;
        }

    }
}
