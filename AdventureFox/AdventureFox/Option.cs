using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureFox
{
    /* This class is used to contain "button" data for navigating between
     Encounters, Rooms, and perhaps more.
     */
    class Option
    {
        #region Properties
        private string text;
        // What the button says on its face.
        private int index;
        /* The "destination" that the option corresponds to in its 
        containing classes. More specifically, it refers to the 
        index of a List. An index of -1 corresponds to "exiting", 
        for options that exit the encounter altogether.
        */

        public string Text { get => text; set => text = value; }
        public int Index { get => index; set => index = value; }

        #endregion
        // End of Properties

        #region Constructors

        public Option(string text, int index)
        {
            this.text = text;
            this.index = index;
        }
        // End of Full Constructor

        public Option()
        {
            this.text = "Option";
            this.index = 0;
        }
        // End of Full Constructor

        #endregion
        // End of Constructors

        #region Methods
        // How many of these does it really need???
        #endregion
        // End of Methods
    }
    // End of Option class
}
// End of namespace