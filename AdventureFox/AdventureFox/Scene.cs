using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureFox
{
    /* This is the "meat" of an Encounter, the individual parts that constitute 
    the story, puzzle, and reward elements. It represents on particular moment of 
    the Encounter, and the different choices the player might make from there.
     */
    class Scene
    {
        #region Properties
        private string text;
        // What the player sees during the scene.
        private List<Option> options;

        /* The options available to the player. These each correspond to other 
        index positions in the containing Encounter class.
        */

        // TODO: Add Resources and Requirements.

        public string Text { get => text; set => text = value; }
        public List<Option> Options { get => options; set => options = value; }

        #endregion
        // End of Properties

        #region Constructors

        public Scene(string text, List<Option> options)
        {
            this.text = text;
            this.options = options;
        }
        // End of Full Constructor

        public Scene(string text)
        {
            this.text = text;
            this.options = new List<Option>();
        }
        // End of Partial Constructor

        public Scene()
        {
            this.text = "There's not really anything to see here...";
            this.options = new List<Option>();
        }
        // End of Default Constructor

        #endregion
        // End of Constructors

        #region Methods
        #endregion
        // End of Methods
    }
    // End of Scene class
}
// End of namespace
