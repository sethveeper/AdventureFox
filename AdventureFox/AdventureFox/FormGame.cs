using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureFox
{
    public partial class FormGame : Form
    {
        Encounter encNote = new Encounter(
            "There's a suspicious note laying on the ground...",
            new Option("Read the note", 0),
            new List<Scene>());

        Encounter encBot = new Encounter(
            "There's a strange robot standing in the corner...",
            new Option("Talk to the robot", 1),
            new List<Scene>());

        List<Encounter> encList = new List<Encounter>();
        public FormGame()
        {
            InitializeComponent();

            Scene Note0 = new Scene(
                "You read the suspicious note:\n\n'Don't read suspicious notes, you idiot!'");
            Note0.Options.Add(new Option("Put the note down.", -1));
            encNote.Scenes.Add(Note0);

            Scene Bot0 = new Scene(
                "'I am programmed for your pleasure. Please assume the position,' the robot states in a flat tone.");
            Bot0.Options.Add(new Option("What?! No!", -1));
            Bot0.Options.Add(new Option("My pleasure is for you to work at the Atomic Wrangler.", 1));
            Bot0.Options.Add(new Option("I suppose I should test you out before I hand you to the Garrets...", 2));
            encBot.Scenes.Add(Bot0);

            Scene Bot1 = new Scene(
                "'Yes, ma'am!' the robot says before lumbering off.");
            Bot1.Options.Add(new Option("(Exit)", -1));
            Bot1.Options.Add(new Option("Wait, come back...", 1));
            encBot.Scenes.Add(Bot1);

            Scene Bot2 = new Scene(
                "'Servos active!' the robot states before giving you what you want...");
            Bot2.Options.Add(new Option("Well, that was... different.", 3));
            encBot.Scenes.Add(Bot2);

            Scene Bot3 = new Scene(
                "'Are you uncomfortable? My servos may require adjustment,' the robot suggests in the same flat tone.");
            Bot3.Options.Add(new Option("No, you performed as intended.", 4));
            Bot3.Options.Add(new Option("That all you've got, robot?", 5));
            Bot3.Options.Add(new Option("I can't feel my legs!", 6));
            encBot.Scenes.Add(Bot3);

            Scene Bot4 = new Scene(
                "'Are you uncomfortable? My servos may require adjustment,' the robot suggests in the same flat tone.");
            Bot4.Options.Add(new Option("No, you performed as intended.", 5));
            Bot4.Options.Add(new Option("That all you've got, robot?", 6));
            Bot4.Options.Add(new Option("I can't feel my legs!", 7));
            encBot.Scenes.Add(Bot4);

            Option OptBotExit = new Option("(Exit)", -1);
            Option OptBotAgain = new Option("I suppose we could go again...", 2);
            Option OptBotOrder = new Option("Report to the Atomic Wrangler. James Garret is your new owner.", 1);

            Scene Bot5 = new Scene(
                "'Excellent. Awaiting further orders.' the robot says in its flat, tinny voice.");
            Bot5.Options.Add(OptBotExit);
            Bot5.Options.Add(OptBotAgain);
            Bot5.Options.Add(OptBotOrder);
            encBot.Scenes.Add(Bot5);

            Scene Bot6 = new Scene(
                "'I will require a hardware and software upgrade to offer enhanced services,' the robot says in its flat, tinny voice.");
            Bot5.Options.Add(OptBotExit);
            Bot5.Options.Add(OptBotAgain);
            Bot5.Options.Add(OptBotOrder);
            encBot.Scenes.Add(Bot6);

            Scene Bot7 = new Scene(
                "'Numbness will subside in several minutes. Awaiting further orders,' the robot says in its flat, tinny voice.");
            Bot5.Options.Add(OptBotExit);
            Bot5.Options.Add(OptBotAgain);
            Bot5.Options.Add(OptBotOrder);
            encBot.Scenes.Add(Bot7);

            encList.Add(encNote);
            encList.Add(encBot);
        }
        // End of Initialization

    }
    // End of Form Game partial class
}
// End of namespace