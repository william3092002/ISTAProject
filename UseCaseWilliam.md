# Use Case Description
**William Chan**  
*August 16, 2020*

#Use Case Name: Create a Project 

**Actors:**
* User
* System
* Project Manager

**Triggers:**
* The user wants to create a project.

**Preconditions:**
* The user is registered to the system and has a userID.
* There is at least one project manager in the system.

**Post-conditions:**
* The project is created with a distinct project ID. 
* The project is assigned to a Project Manager.
* The Project has a basic description.  

**Normal Flow:**
1. The user will navigate to the Project page. 
1. The user will enter the Project title.
1. The user will select a Project Manager from the list he/she wish to assign this project to.
1. The user will input description of the project. 
1. The user will hit the submit bottun to create the project.
1. The system will generate a unique project ID.
1. The system will record the date and time this project is submitted.
1. The system will tie the user ID and user name to this project ID.
1. The system will assign the project to the selected Project Manager.


**Alternate Flow:** 

* Scenario: The user's desired Project Manager is not listed as an option. 
1. The user shall contact a system admin and notify above situation. 
1. System admin will confirm the project manager is still with the Company through HR.   
1. If true, the system admin will modify the list as required and notify user the siutaion has been resolved.  
1. If false, the system admin will notify the user that specific Project Manager is no longer with the company. 



