# Dialog_Manager

## Basic Dialog Manager with Dialogs / Intents / Entitys / Actions (Fulfilment) ##

## Similarly based on Diagflow/Rasa/Bert Conversation systems; ##

### Conversations can be Tailored based on Q&A ###


## GOAL: 
Dialog manager With Intent management and Named Entity recognition: 

### Intents: 
-Contexts (input/Output);
-Parameters (Entitys);
-Responses / Triggers;
-Actions


### Named EntityLists:
Entitys;

### Dialog Manager:
History;
Current topics; 
Named EntityLists
Intents List
UserInput/Response Output

## Dialog Manager Central UI :
Used to test and manage dialog!

## Intent Creator
Used to create User intent

## NamedEntity List Creator
Used to create named entity lists : 

## Actions
enable user actions to be scripted : using VBS Action Script Executed from Dialog When OutputIntent is Triggered(Perform Action) - Performs Action(s)Held in intent (Actions Also HAve customizable responses)

# Description:

This project has been made as a resppnse to the need to create task oriented dialogs, 
The ability to create Questionaires which collect parameters required or follow decison based trees; 
This an essential component to comercially developed chatbots or virtual assistnats; 
The Dialog Management System is a State managment system as well as the main interrogation systems too. 

Dialog is created by the use of intents which are the users intentions such as Greeting etc..
The individual intents can have many triggers or even collect named entitys (parameters).
They also hold Responses which can be used as a pool of responses to give greater vairiaty in response to the users enquirys. 

Design or Advanced Intent detection utilizing Named Entity recognition; 
this enables for the development of Virtual Agent with the ability, to perform Actions based on specific dialog goals and aims. 
Custom actions can be designed and executed on completion of a dialog; 

Dialogs can be themed to a specific set of tasks enabling for multiple dialogs to be held; 

Responses can be completely taylored from the Intent Level to the Entity level and Action Level! enabling for responses to be targetted to specific purpose. 

Dialogs can be exported to JSON and Re-Imported. All Items Can be customized as well as Scripted with customized variables; enabling for focused conversation design. 
The ability to use as a plugin to other chat script being deployed in a personal project is also paramount as this is by no means a FIX ALL although it can be used in such a way! 



### Currently Thinking

Still developing refinements as well as (forgetting to add the conversation interface as with the previous project) although it will be added after testing the first leg of Code Presented here! The intuition with the dialogMAnager / Creator is not for learning but for performing. In agent ocnstruction the problem of learning is handled by test prcesses and machine learning algorithms.  the aim of the dialog manager is to MANAGE DIALOGS. MANAGE DIALOG STATES AND CURRENTLY HELD INFORMATION REGARDING THE CURRENT DIALOG.  the problem when creating chat bots is that the focus and attention is often lost and topic management causes the chatbot to jump from topic to topic without regards for the current process. infomation gathering for the current conversation may only be tempral and not finite therefore it maynot be condusive to save information permenantly. form filling and information collection may lead to a final conclusion and an action is required to be performed with the data collected as well as in data collection confirmations about the currently held data on the conversation maybe required. this is where the current chatbot paradigm fails. and yet we desire loose conversation as well as focused conversation.  the dialog managmement system althouh can be used for loose conversation it is not suited for this task. There for to enable for the chat bot to have the loose style chat the older paradigms are still required. therefore both systems can be deployed side by side. as if there is no current dialog in play then other response can be sought from other paradigms. as well as other learning functions deployed. 
Currently with this dialog manager to simulate the older paradigm the time to live for intents should be set to 0 or 1 being imeadiatly forgotton and not held as current topic etc... enabling for loose conversations... 
Actions instead of Action to be held in the Intent; 

## Feel Free 
to Comment or CONTRIBUTE WITH VB CoDE, COMMENTS/REMARKS  
