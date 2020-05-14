using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Queens
{
    class Location
    {
        int selectedCollum, selectedRow, queens;
        float[,] map = new float[8,8];
        //Float lowest
        //Get starting location from display class
        //Overrides
        //Get starting location with a random location
        public Location()
        { }
        public Location(int collum, int row)
        {
            selectedCollum = collum;
            selectedRow = row;
        }

        //Nested for loop to fill Array
        //Set each location as a float value .1-.7
        //Depending on how many locations it would take up when a queen is on it

        //Get colmunm value(array location)
        //If array location value<lowest
        //Lowest = array location value

        //Function get queen position (array xy, float change value)
        //Sets value of tiles in same row column and all diagonals from queen position if available
        //Change value of queens by +-1
        //Set lowest to 10
        //Then set 88 to location of the queen and add 1 to all locations
        //in the same row and column and in all diagonal detections

        //Next loop through the next rows until there are 8 queens on the 
        //bored or there is no space for a queen with a value of less then 1 
        // If no location for a queen take lastplaced queen and place on 
        //the next lowest number and Mark the last place the queen was at 12.



        //Loop at starting row best case will only need to loop 8 times worst n-1^2
        //Loop row 0 place on lowest value(if value<low value










        //When done send array to display class


    }
}
