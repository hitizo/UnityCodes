1 - Create an empty GameObject in your scene and name it `DialogueSystem`.
Attach the `DialogueSystem.cs` script to it.
Create a UI Canvas with a `Panel` that acts as the dialogue box.
Inside the panel, add a `TextMeshPro - Text (UI)` component for the dialogue text.
Assign the panel to `dialogueBox` and the TMP text component to `dialogueText` in the `DialogueSystem`.

2 - Create an object in the scene (like an NPC or item) that should trigger dialogue.
Attach the `DialogueTrigger.cs` script to this object.
Fill in the `lines` array with the dialogue you want this object to say.

3 - On your Player object:
Attach the `PlayerInteractor.cs` script.
Create an empty child object at the player’s front (like `InteractionPoint`) and assign it to `interactionPoint`.
Adjust the `interactionRadius` to match the distance the player can interact from.
Set the `interactableLayer` to the layer where dialogue objects are placed.

4 - Now you can reuse the `DialogueTrigger` for multiple NPCs/items!!

#############
### SETUP ###
#############

# Layers Setup
   - Create a new Layer called "Interactable".
   - Assign all NPCs or interactable objects with dialogue to this layer.
   - Set the `interactableLayer` in the `PlayerInteractor` to this layer.

# Usage
   - When the player is near an interactable object and presses Space:
     - `PlayerInteractor` checks for objects in range.
     - If an object has a `DialogueTrigger`, it calls `Interact()`.
     - This starts the dialogue sequence in the `DialogueSystem`.

   - Inside the dialogue box:
     - Press Space to skip typing animation or move to the next line.
     - Dialogue ends when all lines are shown.
