using System;
using System.Collections.Generic;
using System.Text;

namespace AdventureFox
{
    /* This is the core class of the game. It is intended to represent dialogue, 
    puzzles, and potentially many other types of encounters. 
     */
    class Encounter
    {
        #region Properties

        private string description;
        // What the player sees before starting the encounter.
        private Option introduction;
        // What the player clicks on to start the encounter.
        private List<Scene> scenes;
        /* What the player might see during the encounter.
        Each "Scene" itself also has "Options", each of which refers to another Scene 
        in the list. Hopefully, this allows us to set up links between any two scenes in
        a given encounter, in whatever fashion we deem appropriate.
        */

        //TODO: Add Resource property???

        public string Description { get => description; set => description = value; }
        public Option Introduction { get => introduction; set => introduction = value; }
        public List<Scene> Scenes { get => scenes; set => scenes = value; }
        // The list of things the player might see during the encounter.

        #endregion
        // End of Properties

        #region Constructors
        public Encounter(string description, Option introduction, List<Scene> scenes)
        {
            this.description = description;
            this.introduction = introduction;
            this.scenes = scenes;
        }
        // End of Full Constructor

        public Encounter()
        {
            this.description = "There's a note on the ground, but it doesn't say anything...";
            this.introduction = new Option();
            this.scenes = new List<Scene>();
        }
        // End of Default Constructor

        #endregion
        // End of Constructors

        #region Methods
        #endregion
        // End of Methods
    }
    // End of Encounter class
}
// End of namespace