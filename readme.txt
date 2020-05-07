To Run:
	1. A Custom page has already been added (and populated) to Top Menu and Footer. Can redirect using the link. 
	2. To create a new page of Homework Page type:
		Please Choose Add "New Page" in Navigation pane. Scrool down to "Custom" page group. Choose homework page.
User Acounts:
	1. Admin (Belongs to CmsAdmin virtual group)- Username: Admin, pass: Admin-123789
	2. Nick (Belongs to CmsEditor virtual group)- Username: Nick, pass: Nick-123789

Problems faces:
	# After Installing packages, saw server error while debuggin. Updating EPiDatabase solved the problem.
	# Form tab not showing in assets pane:
		Steps: 1. Restarted the process, didn't solve issue
		       2. Restarted the Visual Studio, didn't solve issue
		       3. Used Epi community solution: Edit -> profile -> my Settings -> display options tab -> click reset views button. Worked like a charm :D
	# Created Custome page under wrong folder. When deleted that one and created a new one under right folder and using pages namespace, started getting 
	    "No owen.environment was found in context" error. Tried restarting, resetting to previous change, no luck. Finally it started working when i updated
	    Web.config file and added defaultLanguage="c#" to <compilation/>.
	# I added inline CSS styling. To make it more consistent, i created a CSS file and added to BundleConfig.cs. But when i tried to render it in view, it didn't work.
	  tried adding it to root layout and adding that layout to view (view did not have any layout before). Still no luck. Need further investigation.

			