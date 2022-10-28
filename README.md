# TupasKAddingNumbersAPI2

//Peer Review: by Christopher Prado 25OCT22 , your APIinput for MiniChallenge 2 runs effectively. I think its awesome how I can add any 2 number together 
and it's connected to the local host 



Download Appications and Download Code: You need the following appications postman and visual studio code. All must be login or setup before proceding To download 
my code there should be a green button that says code on it. Then copy it and open up visual studio code. Open a new window and click on Clone git Repository. Then 
paste the link in the URL. Make a new folder where you want to put it.

Run the code: You run a Debug then your default browser should pop up a window. It should say localhost can't be found. On top copy the URL then. Go on postman 
and click on workspace in the URL put the URL you copy from the localhost in the URL. It should look like this https://localhost:7214/. Go back on visual studio code 
click on the contoller folder. Look at the names click on AddingNumbersController.cs. By public class copy only "AddingNumbers" ignoring Contoller.cs. Go back on postman and paste
it in the URL. It should look like this https://localhost:7214/AddingNumbers. Go back on visual studio code on the AddingNumbersController.cs. You should see [HttpGet] and under it [Route("Adding/{numberone}/{numbertwo}")]. Copy the text in the quotions marks. Go back on postman and paste what you copy in the URL. Get rid of {numberone} and {numbertwo} 
and input some numbers. It should look like this https://localhost:7214/AddingNumbers/adding/5/5.
