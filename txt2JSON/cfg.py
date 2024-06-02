import os
import glob
import json
import re
import requests

GROUP_NAME =  {
    "Tool & Utilities" :  "SystemTools",
    "Game Launcher" :  "Coding",
    "Browser & Community" :  "Internet",
    "Dev Tools" :  "GraphicsSound",
}
IMAGE_LINK_DEFAULT = "https://raw.githubusercontent.com/hellzerg/optimizer/master/images/feed/7zip.png"
FOLDER = "feed"
PATTERN = r"\[.*?\]"