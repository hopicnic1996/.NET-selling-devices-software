# .NET-selling-devices-software
Task 1 
I. 	Use case diagram 
  
II. 	ERD 
  
III. 	Class diagram 
  
  
IV. 	GUI design  
This will show the function also user interface that I’m going to design for my program Login form: 
  
Before go further user would have to login first. 
Sign up form: 
  
Incase user don’t have the account to login. They can sign-up one. 
Main menu form for admin: 
  
 	This include Add, update, delete for category and product and also can add user. 
Add/update category: 
  
Add/update product: 
  
Orders management form for admin: 
  
Main menu for User: 
  
Order products form for user: 
  
Task 2 
I. 	Files structure of the program 
  
The program contains 7 .cs files. 
When the program starts, Program.cs file creates new Login form as starting point. 
  
LoginForm.cs 
  
In here when user input user name and password into text box then click on login button, it will perform checking form data base if the value exist it will go to main menu form. 
  
Also incase user doesn’t input any values into the textbox this will check and requite user to input them. 
AddUserForm.cs 
  
This is the function for add user new user into the system. This option just available for admin so they are the only one can use this. In here when admin input all information into text box then click on add button, it will perform command to add the information onto data base. 
DashBoardForm.cs 
  
 	Because the dashboard form is available for both user type, so as we see there are few rule in dashboard form for each user type (Admin and customer). After login this form will get username, user ID and also user role that 1 is admin and 2 if customer. For customer, they can’t see the admin tool to add/update/delete for category and product, they just able to give order to a product. For admin they can see and use the admin tool to add/update/delete for category and product, but there are no order button for them to give order to a product. So it been set to “false” and the admin tool is set to “true”. 
  
This function of category listbox, when in the dashboard form user can see the category so they can select them. Each time they select a category the product table will show that category products. This function could be like the search. 
  
This function is for admin only. The admin can see all the add/update/delete function but they are not able to user update and delete function yet because they have to select a product or a category first. When the product table showed products, then admin select a product the button update/delete will available to use. 
  
This function will open a form to admin manage a change of the product. 
  
When click on the delete button. This execute a command to database to remove a product that admin selected from database. 
  
For order button, this will make a execute command into database to create an order of 
 
Each button will open another form such as order form, add user form, add/update category. 
  
In conclusion, this form will show category list, product list when you selected a category from category list. Also with the admin it will show and allow admin to perform add/update/delete form selected value. 
AddCategoryForm.cs 
  
As the form is use for both add and update category, so the add and update button will showup or invisible in different situation. When admin select add new category the add button will appear and update button will disappear. So when admin select update category the add button will disappear and the update button will appear. 
The add button will add new category into database and the update button will make change of current category that admin selected. 
  
This form show-up when admin choose Add or Update category Function. If choose add new form will appear. If choose update the form will get information then fill text box. Each function will appear different button Add or Delete button. 
 
Same as add or update category. This form will show-up for admin to add new product or edit information of a product. As this form is for both add new and update current product so it will show with different button. 
  
When admin select update a product this will get the information if that product then fill it into the textbox so user can edit then then click update. 
OrderForm.cs 
For the order form, it is use for both user type (admin and customer) the form will based on the user role to disable and enable the function. 
  
When select a order from order table, users can see all the information on the textbox at their left screen. For Customer, they just only see their order but with admin they can see all the order of all customers. 
  
different function base on their name such add make change of the order and remove that order form database. 
  
This form show all the order information of the user. For admin it will show all the order information of all users. 
II. 	Graphical components 
Login Form 
  
In login form there are 1 picture box, 2 label to user know to enter which text type into 2 text box. There are 2 button one for login and the other to close the program. The last once is linkLabel that allow to click on it. 
  
DashBoard Form 
  
As Dashboard form is main menu and allow user to use almost function. With mean it have 1 list box to show category and 1 gridview to show products. There is a toolStrip that contain 3 two toolStripMenuItem and a menuStrip that contain 9 ToolStrip. There also 2 button and a tabControl which contain a tabPage. About 2 bindingSource, it is used for the ListBox and GridView. 
  
AddUser Form 
  
This form contain 3 label that show direction to user know what to enter in 3 textbox. There also 2 button. 
  
AddCategory Form 
  
This form contain 2 label that show direction to user know what to enter in 2 textbox. There also 3 button. 
  
Add Form (For product) 
  
This form contain 4 label that show direction to user know what to enter in 3 textbox and what is in the comboBox. There also 3 button 2 to perform that action and one other is to load image into the picturebox. 
  
Order Form 
  
This form contain 7 label that show direction to user know what is in 5 textbox, DateTimePicker, and ComboBox. There also 5 button and a GridView.  
  
Task 3 
First, we need to differentiate the difference between the two types of applications: Windows and the Web. When the first Web application was created, one would distinguish the two types of applications from the following: The Windows app runs on the Desktop or on a local-Area network, while the WEB application is run on a remote Server and accessed using a Web browser (Web browser). This difference is no longer obvious because Windows apps now tend to use WEB services. For example, Outlook software converts the mail through a WEB connection. 
 
Desktop-based application is an application that runs stand-alone in a desktop or laptop computer. Different than "Web-based application," which are requires the Web browser to run. The Desktop-based application runs on a PC operating system such as Windows, Mac, Linux, etc. it has a graphical user interface and it does not run inside a web browser. The term that may be used to contrast desktop applications with mobile applications that run in smartphones and tablets. Between the Windows and the Web application which one owns the UI? 
In my opinion, the application uses the browser to display or Unite application is built into the program that can run on the Desktop. There are some advantages to the WEB application, the application can be accessed by any browser that connects to the Server, the calibration is done on the Server, there is no need to distribute the new dynamic link library (DynamicLinkLibraries-DLLs) needed to run the application for Users. Dot NET also has this distinguished, typically having the appropriate toolkits for each type of application: Windows or Web. Both types are based on the Form template and use the controls (Control) such as Buttons, ListBox, and Text... The current Windows and WEB application has many similarities, and .NET should be bundled into a generic toolkit for both Windows and WEB applications in the coming version.  
Web App is a Web-based application that performs a number of basic functions such as sharing images, computing, shopping... That you can easily reach through the Internet or the Internet. Applications can be as simple as a message board or complex as a multiplayer gaming app. These apps are becoming more popular in these days because they don’t require user to installation, manual updates, or hardware upgrades. 
Mobile APP is a mobile application that allows you to access the content you desire on devices such as mobile phones. 
In this scenario, Windows Form is chosen for develop the application. It gives user easier access to the software and its functionalities. Moreover, a desktop is the most stable among the three types of delivery environments. 
To exchange data with database, Technology ADO.NET  are used. It is the model that allows programmers to manipulate multiple types of databases in the same way. DATABASES can be SQL Server, MS Access, Oracle ... Each DB type will be the appropriate .NET Framework Data Provider. Includes objects of the Data Provider classes used to manipulate the DATABASE 
To start connection to database you would have to follow these code: 
First enter this code to access the spl command data: 
  
Then enter this code inside the method to connect into the database of Microsoft SQL server: 
  
Task 4 
I. 	Program screen  
Login Form 
First when run the program, user would have to enter their account which is user name and password to go further. If they does not have an account yet they can register by click on Join us!. 
  
Register Form 
User would have to input user name, password and re-type the password then select confirm. After have an account they can enter it at login screen to move to main menu 
  
DashBoard Form 
Known as Main menu, this form will allow user to see Categories and products, also do some action with some button. The button will appear depend on the account role. There are 2 role Admin and Customer. 
For admin: 
  
Admin are allow to make change to category and product. They can add new, change information and also remove them. 
For Customer 
  
The customer are allow to make order from the product they choose. 
AddUser Form 
  
AddCategory Form 
  
Add Form (For product) 
  
Order Form 
The order form are available for both admin and customer but it will show different. For admin 
  
Admin can see all the orders and also make change of their status. 
For customer 
  
The customer can see all of their orders and also cancel the order. 
 
II. 	Error handling 
In login form: 
When user input user name and password, if one of the username or password are blank message box will show up and tell them to input it. 
  
Also if the account user input does not exist or they enter wrong password, message box will show up. 
  
Register form: 
When user try to register if they account already exist the message box will appear. Also as they have to enter the password twice to make sure both are the same but if one of those are not the same 
 
 
