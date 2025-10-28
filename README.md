# in-class-activities
## Devlogs
### W1
Hello world

### W2
1. Because the r, g, b values are supposed to be fractional numbers between 0 and 1, so they belong to the float type of variables.
2. Because the number of bounces is supposed to be a whole number, so it belongs to the int type of variables.
3. The line missed the semicolon at the end of the line, which is supposed to act as a mark to the end of a whole line.

### W3
1. Table 7. The parameters (input) are an integer value that represents the player's current friendship level with the character (int friendshipLevel) and a boolean value that represents whether the player knows the character's secret (boolean knowsSecret). The return type (output) is a string variable that is the text response to the player's dialogue choice (string characterResponse).
2. If each Component is a robot, then class is the blueprint to produce the robot, member variables are traits of the certain type of robot (size, material, etc.) and methods are the robot's functions (sweeping the floor, cleaning the table, etc.)
3. Every time the ball's speed reaches over _speedThreshold, the ball's renderer's color values multiplies by 1.5, and as we know the higher the values r, g, b are, the brighter the color of the renderer is. And since the method is multiplying all three values at the same time, it gets infinitely close to 1,1,1 (pure white).

### W4
Table 7
1. line 5: defines a member variale. float named _moveSpeed, which is supposed to be the value of the move speed multiplier, and set it to 1.0f
2. line 22: defines and calculates the value of the float translation, which is multiplied from: 
(a) gets key input. calls the method Input.GetAxis("Vertical"), a value that is either 0 or 1 since the key is either pressed or unpressed. If the key is pressed, it is set to 1, and the value of translation may not be 0. If the key is unpressed, it is definitely 0. 
(b) _moveSpeed, which is the custom speed multiplier, a member variable defined in line 5. 
(c) Time.deltaTime, a value to keep track of time passed since the last frame. Since this line is inside of the Update() method, it is executed every frame and calculates the speed of the object according to player input every frame. 
Typically, only the key input part changes due to the player's input changes, it is used to keep track of whether the player pressed the key or not. If not, it is set to 0 and the object won't move.
3. line 25: calls transform.Translate() and actually translates the object's position. transform.Translate() is used to move objects' positions. The (0, 0, translation) values mean that we are only changing the Z axis position of the object according to the value of the float variable translation.

### W5
Q: What is the GetComponent function? What does it do?
A: The simplest case is where a script on a GameObject needs to access another Component attached to the same GameObject (other scripts attached to a GameObject are also Components themselves). To do this, the first step is to get a reference to the Component instance you want to work with. This is done with the GetComponent method.

## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 