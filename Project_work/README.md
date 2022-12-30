# Instruction for using the game

### If you want to use the rfid reader you need to make sure to select the right COM port:
1. Go to the Arduino IDE and open the serial monitor. When selecting the board and port just select any arduino board (it doesnt matter) and select the right port of the reader.
2. You don't need to run anything, just hold the card to the reader and see if you get something in the serial monitor, if you do you can use that port in unity
3. In Unity click on the SerialController and enter the COM port that is used by the rfid reader 
   * COM1, COM2, ... for COM1 through COM9 
   * \\.\\COM10, \\.\\COM11, ... for COM10 and up
4. There you go, should be working now (if not just ask me)

### If you don't want to use the reader:
1. Just go to the SpawnerScript.cs and set a fixed object id
2. Depending on what object you want to spawn uncommend one of the lines
3. There you go, should be working now (if not just ask me)

Good luck and have fun working on the game :)