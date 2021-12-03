To Run:

	To run, load the solution file in Visual Studio and hit the 
	start button or simply double-click the executable in either 
	the bin/debug or bin/release folders.

To Use:
	
	Default files should be loaded automatically, if they are 
	missing, the program will not run.  This is because I didn't 
	want to deal with a situation where one or more tables are  
	missing, so I just don't allow that to ever happen.

	Several options are available from the menu bar that aren't 
	available from the buttons.  Everything you need is available
	from GUI.  The various browse buttons open a file dialog for
	the tables and source file.  Note that the tables must be in 
	the proper format or they may not be read in properly or the 
	program may exhibit odd behavior.  "Next Token" reads a 
	single token. "Auto Scan" reads the whole whie by getting the
	next token until EOF is hit.

What is this?:

	This is a lexical analyzer written in C#.  Its purpose is to
	scan a source code file and identify collections of characters
	and return what token category they are.  These tokens are 
	then fed to a parser.

	To do this, the analyzer uses a couple of tables (stored as 
	CSV files).  The scan table consists of states and the 
	transistions between those states.  The first row consists
	of all the legal characters in the langauge.  You always start
	at state 1.  If you get a '{', then you find the instersection
	of your current state and the column of '{' and then move to 
	that state.  This repeats until a '-' is found in the table.

	We then look into the token table using our current state as 
	an index.  If the token is prepended with '-', then it is an 
	error state, and the error flag and message are set.

	If it is a valid token, we then look up the lexemme in the 
	keyword table (a set or map in code) to see if it is a keyword.
	If so, the token category is changed to be the same as the 
	lexemme.  For example, "int" is an "indentifier", but since it
	is also a keyword, we change the token category to "int".

Updates & Misc.:

	Row numbers are now printed out with error messages.  It 
	wouldn't be all that difficult to also do column numbers, but 
	I don't really want to add all that code in.  The overall 
	structure has remained the same.  Things were overall easy to 
	translate, and I wish Python could do the partial class stuff  
	as it would have kept my GUI class a bit cleaner and easier to 
	read.  A few small design changes were made, but is pretty 
	much the same program.

	Also, I straight up modified the auto-generated code because 
	I think I know better, so you can't load the design view.  The 
	code is all there, though.