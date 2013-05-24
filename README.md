KioskTimer
========

KioskTimer was created to provide some control over how long a user could use a public computer. It allows you to set a timeout to a session and then lets you set how long before a new session can be started. This tool is perfect for small library's that don't wish to use a server/client based solution.

There are two parts to the software, 1) The KioskTimer which handles session management and 2) A settings GUI tool.

Requires Microsoft .NET Framework 4


Configuration
-----

All settings are held in the registry under one key:

64 bit Windows systems:
HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Faulk_Me\KioskTimer

32 bit Windows systems:
HKEY_LOCAL_MACHINE\SOFTWARE\Faulk_Me\KioskTimer

#### Coors
* BackgroundColor [DWORD] - The KioskTimer background color.
* ForegroundColor [DWORD] - The KioskTimer foreground color.

#### Times
* Timeout [DWORD] - Session time.
* LockoutTime [DWORD] - Time before a new session can start.
* WarnTime [DWORD] - Time before session ends that user will get WarnMsg altering them to the session almost ending.


#### Messages/Text
* LogInMessage [SZ] - The message on the main screen of the KioskTimer. (Excepts variables: see Message Variables session)
* UserLogInButton [SZ] - The text of the button the user will click to start a session.
* WarnMsg [SZ] - The Message the user will get before the session ends. (Excepts variables: see Message Variables session)

#### Other
* PasswordHash [SZ] - A BCrypt hashed password.


Message Variables
------

* %sessiontime% - Timeout time.
* %warntime% - Time left warning time.



You can find more of my tools at http://faulk.me