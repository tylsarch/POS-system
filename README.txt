Welcome to the POS-System by Ruchik Patel and Tyler Archer!

The Goal of the this system is to provide a simple and efficient way for small startup businesses to maintain a database for their inventory.

Before you can get started with the program, there are a few things that need to be done. First be sure you have Microsoft Access, otherwise you will not be able to
view the database inventory or credentials. Next, find the location of the file "Database2" (type: ACCDB) and right click on the file. Locate to the "properties" and left
click. Copy the location of the file as you need to configure the source of the program. Next, open the project files pos_interface.cs, Form1.cs, inventory_changes.cs, and 
new_user.cs and locate the line that says 
"new_connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\POS_PROJECT\inv3_test\inventory\inventory\Database2.accdb";".
Delete "G:\POS_PROJECT\inv3_test\inventory\inventory".
Now you should have: "new_connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\Database2.accdb";".
Move your cursor and left click to move the cursor between "Source=" and "\Database". Right click and copy the location into this section to have a fully functional source.
If you continue to have no connection, please contact customer support (Tyler Archer or Ruchik Patel).

Locate the start button with a green triangle in visual studio to run the program.

Click create new account to make your very own account. "Admin" is the Admin username and "rude" is the Admin password. If you do not wish to create a new user you can simply
log in with the Admin credentials.

The Workflow can be found in "Descriptions.pdf" for the rest of the main project, but there are a few bugs the user should be aware. When the user clicks on "Inventory" to go
to the inventory, in order to get an accurate representation of what is being deleted, the use must select the barcode they wish to delete and type in the textbox next to
"Barcode:" the barcode they wish to delete. Add and save function the same but the user must fill out all tables in order to insert an item. Note, you will not be able to
view any of these changes until the program is exited started once again. We are working on getting these issues resolved. Also there is no functionality to the Help and
Options button as we each individually spent too long on other portions of the project that were buggy.

Our commit history is terrible as we both know, but the reason is because of the source changes listed above. it is a simple copy and paste but we would have had to
constantly change sources as our repos were slightly different. The slightest difference means we lose connection completely and we would have a constant battle between the
two codes. It was a hassle that was not necessary. while we have versions with different sources, the changes are miniscule.