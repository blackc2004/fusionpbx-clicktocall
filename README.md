# fusionpbx-clicktocall
Windows .NET app for Click TO Call on FusionPBX

Build the project in Visual Studio.

Double click to run, it will then launch a system tray application. 

Right click on the application in the system tray and click settings, populate the domain (IE: pbx.fusionpbx.com no HTTP/HTTPS) as it defaults to HTTPS only, API key and your extension. You need to have the API-Key option from the users in fusionpbx.

Then go to an application, I’ve tested with word, chrome, ie, excel, notepad, highlight a phone number. Press CRTL-SHIFT-C

You should then see a popup in the lower corner saying “calling…” with the phone number. You extension should hopefully then ring, once you answer the phone, it will start placing the call to the other party.