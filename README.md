NASA MARS ROVER

This project is used to fetch the data from NASA Mars Rover Photos API. Earth date is used as a parameter to get the photos. The application reads the dates from the text file in different formats, queries the API and provides the output as images which are downloaded on the local desktop and once all the images are downloaded, it gets displayed on the web browser.

Steps to run the application:
1. Open the resources folder.
2. Open dates.txt file and make changes and enter multiple dates in each line as input.
3. Run the application.
4. The application will start and a folder (if not already exists) named "Mars-Rover" will be created on the local desktop.
5. All the images will start downloading (takes ~60 seconds depending on the size of query request).
6. The names of the images downloaded would be as per the ID mentioned in the API.
6. Once all the images are downloaded, it will be displayed on to the web browser.
7. All the images displayed are clickable and the link will redirect to the image source.

Below is the screenshot of the output after the images were downloaded.
![Output Image](https://github.com/jatin1609/NasaMarsRover/blob/master/Output.png)

Future Scope:
1. A folder selection can be added to browse the dates.txt file so that the file could be accessed from anywhere.
2. A target folder option could be given to the users where he wants the images to be downloaded.
3. Date picker could be added if the user wants to display the images on the browser only.
4. Images could be displayed on the browser first and the user can select the images to be downloaded as per the requirements.
5. Incase of large number of images to be displayed, pagination can be added for better UI experience.
