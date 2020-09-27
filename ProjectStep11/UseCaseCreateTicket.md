# Use Case Description
**William Chan**  
*September 27, 2020*

#Use Case Name: Create a Ticket 

**Actors:**
* User
* System

**Triggers:**
* The user wants to create a ticket.

**Preconditions:**
* The user is registered to the system.

**Post-conditions:**
* The Ticket is created.

**Normal Flow:**
1. The user will navigate to the Ticket creation page. 
1. The user will enter the name of his/her Ticket.
1. The user will select a project ID.
1. The user will select a type between bug and feature.
1. The user will select priority of this ticket. 
1. The user will select status of the ticket.
1. The user will input description of the ticket.
1. The user will submit the ticket.

**Alternate Flow:**
* Scenario 1: Description is over 250 chartacters. 
1. The system won't allow the user to submit his/her description.
1. The user shall shorten his/her description.  



