## Console application example
This project contains examples for connections of all three app types including authenticators for public and partner applications.
It is a console application and the authentiation is done using oob callback. This will launch a browser on the users machine and prompt for the PIN. The token returned will be stored. If the applciation is run withing 30 minutes of the authorisation, the user will not be prompted to login.

You will need to enter appropriate values in the appsettings.json file.
