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
1. The deployed Rovers are not complex based off the single string move command input requirement. As a result the Rover will not be able to recognize that any movement command will send it out of bounds. Thus Rover deployment should be terminated if such an event occurs.
1. To deploy new Rovers the current Rovers movement commands need to be deemed successful. Thus after input of the Rover movement parameters the movement commands of the current Rover must be excecuted and deemed successful before new Rover input parameters are collected.

## User Interaction
- Users interact with the application through a series of questions presented in the Console
- Users input is typed into the Console interface
- Users input is controled and guided so that users provides the proper response to the question presented

## Considerations
- If running application on MacOS delete or comment out `Console.SetWindowSize(150, 30)` within the Program.cs file. If this is not done it will throw an error and not allow application to run.
- `Console.SetWindowSize(150, 30)` is used to set the ideal Console Window size to properly view application
- If `Console.SetWindowSize(150, 30)` is removed enlarge Console Window size manually at or above 150 width and 30 height for best experience.

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
![image](https://user-images.githubusercontent.com/47017138/88110780-a04eb380-cb61-11ea-81da-2a9481c942b3.png)

##### Using the Application
![image](https://user-images.githubusercontent.com/47017138/88110912-dab85080-cb61-11ea-8a51-0423081c908e.png)

![image](https://user-images.githubusercontent.com/47017138/88111061-18b57480-cb62-11ea-94bc-3fb0ab1ba50d.png)


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

Input not valid Y/N:\
![image](https://user-images.githubusercontent.com/47017138/88110201-a42e0600-cb60-11ea-8f9c-00b8c881fa14.png)

##### Application End
![image](https://user-images.githubusercontent.com/47017138/88101953-a8075b80-cb53-11ea-960b-ce75500b3ef5.png)

------------------------------
##### References
https://github.com/JangirSumit/mars-rover-problem for verification of initial logic and understanding of problem domain.

## Change Log
