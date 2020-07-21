# Rover On Mars Console Application
------------------------------

# Rover On Mars
##### *Author: Jon Rice*

------------------------------

## Description
Console application that simulates deployment and movement of a Rover on Mars. Users are asked a series of input questions to set up the search area, rover start position/direction and the commands to move/turn the rover. 

## Problem Requirements
A squad of robotic rovers are to be landed by NASA on a plateau on Mars.
This plateau, which is curiously rectangular, must be navigated by the rovers so that their on board cameras can get a complete view of the surrounding terrain to send back to Earth.
1. A rover's position is represented by a combination of an x and y co-ordinates and a letter representing one of the four cardinal compass points. 
1. The plateau is divided up into a grid to simplify navigation. An example position might be 0, 0, N, which means the rover is in the bottom left corner and facing North.
1. In order to control a rover, NASA sends a simple string of letters. The possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the rover spin 90 degrees left or right respectively, without moving from its current spot.
'M' means move forward one grid point, and maintain the same heading.
1. Assume that the square directly North from (x, y) is (x, y+1).


## Assumptions
1. The deployed Rovers are simple based off the single string move command input requirement. As a result the Rover will not be able to recognize that any movement command will send it out of bounds. Thus Rover deployment should be terminated if such an event occurs.
1. The successful deployment of successive Rovers depends on each Rover being able to successfully complete its movement commands. Thus calling the RoverMove method is allowable before collecting inputs for successive Rovers.

------------------------------

## Getting Started
Clone this repository to your local machine.
```
$ git clone https://github.com/RevYolution/RoverOnMars.git
```
#### To run the program from Visual Studio:
Select ```File``` -> ```Open``` -> ```Project/Solution```

Next navigate to the location you cloned the Repository.

Double click on the ```RoverOnMars``` directory.

Then select and open ```RoverOnMars.sln```

------------------------------

## Visuals

##### Application Start
![image](https://user-images.githubusercontent.com/47017138/88101034-472b5380-cb52-11ea-88bb-7b267ef43859.png)

##### Using the Application
![image](https://user-images.githubusercontent.com/47017138/88101183-7cd03c80-cb52-11ea-93d9-229f4c9069c5.png)

![image](https://user-images.githubusercontent.com/47017138/88101337-ac7f4480-cb52-11ea-8967-8bd48ee5a5ec.png)


##### Possible Error Messages
Input out of area bounds:\
![image](https://user-images.githubusercontent.com/47017138/88101439-d6386b80-cb52-11ea-8f02-06feda0060ef.png)

Input not a positive integer:\
![image](https://user-images.githubusercontent.com/47017138/88101559-054edd00-cb53-11ea-9884-2b3c5daa2594.png)

Input not a valid direction:\
![image](https://user-images.githubusercontent.com/47017138/88101649-257e9c00-cb53-11ea-8acc-52d0e2a39be4.png)

Move Command Input contains non valid movement commands:\
![image](https://user-images.githubusercontent.com/47017138/88101751-5068f000-cb53-11ea-80e3-c89514c736c2.png)

Move Command Input results in Rover out of area bounds:\
![image](https://user-images.githubusercontent.com/47017138/88101891-8dcd7d80-cb53-11ea-86e4-9dfccdaa7aba.png)


##### Application End
![image](https://user-images.githubusercontent.com/47017138/88101953-a8075b80-cb53-11ea-960b-ce75500b3ef5.png)

------------------------------

## Change Log
