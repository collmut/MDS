<h2>
	MDS (Mutating Data Structure)
</h2>
<h4>
	Its a string , its a list , its an array , its a graph maybe , it can store almost 
	everything.
	<br>
	Its mutating !!!!!!!!!!	&#60;insert pixar studio screams&#62;
</h4>
<br>
<h4>
	Why this data structure
</h4>
	I just wanted to try creating a string that is a collection . Thats the first idea. 
	And then i just thought , why not create a Datacontainer that represents different data in
	 strings , and the data can be of many types 
<br>
	Example , i can store an array of elements in one string ,Or a list of different elements of different types in one single string , and be able to access it rapidly. 	
<br>
<br>
<p>
	You can easily change the mode of dataStorage in the universal data container to the specific kind you want.
<br>
	Example : you can use List mode [the standard default mode of the data container] 
<br>
	or list mode [allows you to store different types of values]
<br>
</p>

<!--Example code section -->

<code>

	int A = 7;
	int B = 8;

	Mds.Ucont myArray = new Mds.Ucont();		// create instance of ucont container.

	myArray.AddElement(A);				// add the element to the array.
	myArray.AddElement(B);

	myArray.RemoveElement(index:1);			// remove the element on the passed index.

	string C = myArray.GetElement(index:0);		// get the element from the container as a string.
	
</code>
