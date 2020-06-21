# DialogManager (Version 1)


based on DialogFlow! 

## GOAL: 
Dialog manager With Intent management and Named Entity recognition: 
The dialog manager design enables for Topic detection/Detect and respond/Slot filling/Actions based on Specific user requirements. Exporting/importing of JSON 

### Intents: 
-Contexts (input/Output);Keeping the conversation on track; Dialog flow can be used to direct where the conversation needs to go whilst maintaining a history of the current topic being discussed; storing the collected "Slots" for use throughout the current conversation train.
-Parameters (Entitys);(Slots to be detected in the user script)(Topics to be detected)
-Responses / Triggers; This detect / respond technique allows for multiple ways a single thought could be detected; Associated keywords or phrase can be used as triggers which act like detectors for the otpic or intention.



### Named EntityLists:
Entitys;
Collections of entitys or expected types can be keep in lists along with thier triggers as well as fallback responses; a single entitys could be replicated in the list with differing triggers pointing to the same entity; 

### Dialog Manager:
The dialog manager contains a subsection of managment tasks;
  History;
  Current topics; 
  Named EntityLists
  Intents List
  UserInput/Response Output

## Dialog Manager Central UI :
Used to test and manage dialog! The user statement can be presented to the dialog manager which holds the Intentions for the current dialog as well as the entitylists. 


## Intent Creator
Used to create User intent

## NamedEntity List Creator
Used to create named entity lists : 

# summary:

This project has been made as a resppnse to the need to create task oriented dialogs, 
The ability to create Questionaires which collect parameters required or follow decison based trees; 
This an essential component to comercially developed chatbots or virtual assistnats; 
The Dialog Management System is a State managment system as well as the main interrogation systems too. 

Dialog is created by the use of intents which are the users intentions such as Greeting etc..
The individual intents can have many triggers or even collect named entitys (parameters).
They also hold Responses which can be used as a pool of responses to give greater vairiaty in response to the users enquirys. 





