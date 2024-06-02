# RGBTool 

## Text Formatting 
```
[Categorical 1]
Toolname; download link; download link; image link
[Categorical 2]
Toolname; download link; download link; image link
...
```
```
[Tool & Utilities]
7-zip; https://drive.usercontent.google.com/download?id=1Yb8VNrCGJC0_l3msAcjtfyZAAkGiVWSM&export=download&authuser=0&confirm=t&uuid=c42e4bfa-ac67-4ab4-944d-d4487cc553c5&at=APZUnTX23IsJqj0vSRzCcuZMRXXR%3A1716700186255 ; ; https://raw.githubusercontent.com/paimon3107/appImages/main/7zip.png
```
## Json Formatting
```
Title, Link64, Link, Tag, Image, Group
```

```
{"Title": "7-zip", 
"Link64": "https://drive.usercontent.google.com/download?id=1Yb8VNrCGJC0_l3msAcjtfyZAAkGiVWSM&export=download&authuser=0confirm=t&uuid=c42e4bfa-ac67-4ab4-944d-d4487cc553c5&at=APZUnTX23IsJqj0vSRzCcuZMRXXR%3A1716700186255", 
"Link": "", 
"Tag": "c7zip", 
"Image": "https://raw.githubusercontent.com/paimon3107/appImages/main/7zip.png", "Group": "SystemTools"}
```
## Allowable/Disallowable Downloading
```
__excute(down_image = True) (Allowable Downloading)
__excute(down_image = False) (Disallowable Downloading)
```
## Txt2JSON Conversion
```
cd txt2JSON
python .\main.py
```
Move feed.json file -> bin/debug/ and bin/release
Push feed.zip 