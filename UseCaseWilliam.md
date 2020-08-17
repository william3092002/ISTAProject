# Use Case Description
**William Chan**  
*August 16, 2020*

#Use Case Name: Create a Project 

**Actors:**
* User
* System
* Team Leader

**Triggers:**
* The user wants to assign the project to a team and track its progress.

**Preconditions:**
* The user is a project manager and he receives a new project to manage.
* The user is registered to the system with valid contact information.

**Post-conditions:**
* The project is created with name, ID and description. 
* The project is assigned to a team leader.
* A due date is assigned to the project.
* The team leader who has been assigned to the project will receive an e-mail notification.

**Normal Flow:**
1. The user will navigate to the Project submission page. 
1. The system will generate a default status as "unassigned"
1. The user will enter the name of his/her project.
1. The user will enter the project ID.
1. The user will assign the project to a team leader registered in the system.
1. The user will input a due date to the project. 
1. The user will enter the description of the progress or anything he wishes to inform the project manager.
1. The user will hit the submit bottun to create the project.
1. The system will use today's date as date project created.
1. The system will change the status to assigned.
1. The system will assign the project to the selected team leader.
1. The system will notify the team leader assigned to the project with a e-mail.

**Alternate Flow:**
* Scenario 1: The project ID entered by the user is identical to another project already in the system. 
1. The system will notify the user the project ID entered is already in the system.
1. The user should check if project ID entered is valid. 
1. If it was a mistype, enter the correct ID. If not, change the project ID. 

* Scenario 2: The user's desired team leader candidate is not in the list of selection. 
1. The user should contact the system admin to and provide the team leader's name to be input into the system.
1. System admin will confirm given named employee's title with HR.   
1. If given named employee is a team leader, the system admin will add that name to the list of team leaders.
1. If given named employee is not a team leader, the system admin will notify the user. 


