# MSTest-Google-Facebook

Tasks : 
1) Use MSTest to write tests 
2) Automate Google Search using Selenium Wedriver
3) Automate Facebook Login and Navigation (to profiles and tabs) using Selenium Webdriver

Workflow:

TestInitialize 
1) Opens up the browser
2) Maximize browser
3) Set implicit time wait ( which stays for entire session)

TestMethods :
i. TestMethod0 (Google Search WorkFlow) :
1) Go to the Url "http://google.com"
2) Finds the element with the Name "q" and enters "Regression Testing" there and press Enter (keyboard)
3) Press browser's back button
4) Press browser's front button                  
5) Refresh current page
6) Prints current page title from the browser
7) Exception handling is also used

ii. TestMethod1 (Facebook Login WorkFlow) :
1) Go to the Url "http://facebook.com"
2) Finds the element with the Id "email" and fills "enter your email" there
3) Finds the element with the Id "pass" and fills "password" there and press Enter (keyboard)
4) Extract the profile element and click            
5) Extract the "Friends" tab and click 
6) Verify if the Friends tab is displayed on current page
7) Exception handling is also used

TestCleanup : 
1) Closes the browser
2) Quits
