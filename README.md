Prepare a category named “Person”, and the objects of it contains the names of persons, addresses, phone numbers, date of data recording and a serial number! Make the class to be saved (serialization) but the serial number should not be saved!

Prepare the operation of clicking the “Save” button that manages the operation, which saves the objectum of “Person” - created by the data fields - into the file of personxx.dat (in which xx is the serial number of the person, and it can store 99 persons max.)

At the start of the application the first person should be restored (deserialization) and its data should be appeared in the fields!

Implement the IDeserializationCallback interface with the person class! Make the OnDeserialization() operation calculate the value of the serial number data member!

Prepare the operations of clicking the “Previous” and “Next” buttons that manages the operations, which make the previous and the next data of the persons appear in the fields in accordance with the serial numbers.
Upload your Github repository link which contains your project's source code.