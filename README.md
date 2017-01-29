# Prism Assigning Parent ViewModel to Child View if No View Model Example

This example shows that when attempting to navigate to a view that does not have a view model.

To use this program, simply compile and launch. Pressing the navigate button will change the Content region from ExampleContentView
to SecondContentView. Neither of these views have view models. 

When you press the Navigate button, an exception will be thrown from the ShellViewModel OnNavigatedFrom. This is not expected as the
ShellView is not changing. 

Uncommenting line 13 from ExampleContentView.xaml.cs (explicit assigning of a DataContext) will fix the problem and navigation will 
occur correctly.

I included a copy of the RegionNavigationService.cs from the current master branch of prism for easier debugging. To remove, 
comment out line 18 in BootStrapper.cs

If you debug the program with a data context assigned to ExampleContentView with a break point at line 258 of RegionNavigationService,
you will find that the views data context is null. After this line is run, the View has a DataContext of ShellViewModel.
