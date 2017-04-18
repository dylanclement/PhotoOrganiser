var fs = require('fs');
var path = require('path');
var ExifImage = require('exif').ExifImage;
var moment = require('moment')
var inputDir = 'E:\\Pictures\\2016\\2016-09-11'
var path = require('path')

try {
    // Loop through all the files in the temp directory
    fs.readdir(inputDir, function (err, files) {
        if (err) {
            console.error("Could not list the directory.", err);
            process.exit(1);
        }
        files.forEach(function (file, index) {
            let ext = path.extname(file)
            if ([".jpg", ".jpeg"].indexOf(path.extname(file)) != -1) {
                new ExifImage({ image: inputDir + "\\" + file }, function (error, exifData) {
                    if (error)
                        console.log('Error: ' + error.message);
                    else {
                        let date = exifData.exif.CreateDate;
                        let gpsdate = exifData.gps.GPSDateStamp;
                        console.log(file, ' date = ', moment(date, "YYYY:MM:DD hh:mm:ss"), moment(gpsdate, "YYYY:MM:DD")); // Do something with your data!
                    }
                });
            }
        })
    })
} catch (error) {
    console.log('Error: ' + error.message);
}