# DialogueSystem
 A reusable dialoguesystem


# How I made his work:
I made this dialogeu system out of 3 scripts total, a DialogueManager, a Dialogue script and a trigger script.

# What does each script do:
The Dialogue Manager:
The dialogue manager starts, scrolls through and can end any dialogue you've entered

The Dialogue script:
This is the script where the dialogue and the name of a npc or object will be saved, keep in mind that this script doesn't use MonoBehaviour, 
nor will it actually be placed in the game on a object.

Trigger script:
The trigger script is the script you use to activate the Manager to acivate the dialogue, you can also acces the dialogue script from here,
that's why when you place this script in your game you'll have to type the Dialogue and Name in the inspector on the object this is on.

# What you need to do to properly use it in your own game:
 - 1st of all download the scripts given in my github (exclude the gitignore).
 - 2nd place them in your Unity Engine (doesn't matter which script or if they're seperated or not).
 - 3rd you create a empty object, place add the Dialogue Manager to that object in there you have to place 2 texts one for the name 1 for the dialogue.
 - 4th be sure to use UI Buttons to use for activating / scrolling through / Ending dialogue.
 - 5th place the trigger script on one of the buttons (that's the way  made it work).
 - 6th once filled in drag and drop the trigger script onto the on click event of the button, and make sure to use the "Interactable.TriggerDialogue" function.
 - 7th on the other button you wanna drag and drop the DialogueManager gameobject onto the on click even and select DialogueManager.DisplayNextSentence.
