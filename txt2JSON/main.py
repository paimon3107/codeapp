from cfg import *

def __download_image(url, folder_path):
    if not os.path.exists(folder_path):
        os.makedirs(folder_path)

    file_name = url.split('/')[-1]
    file_path = os.path.join(folder_path, file_name)

    response = requests.get(url)
    if response.status_code == 200:
        with open(file_path, 'wb') as f:
            f.write(response.content)

def __excute (down_image = False):
    list_dict = []
    with open("list_app.txt", "r") as file:
        file_content = file.read()
        matches = re.findall(PATTERN, file_content)
        data = file_content.split("\n")
        for line in data:
            dict= {}
            if line in matches:
                group = line.replace("[", "").replace("]", "")
                print(group)
            else:
            
                data1 = line.split(";")
                
                if len(data1) >=2:
                    dict["Title"] = data1[0].replace(" "," ")
                    
                if len(data1) >=2:
                    dict["Link64"] = data1[1].replace("\n", "").replace(" ","")
                else:
                    dict["Link64"] = ""

                if len(data1) >=3:
                    dict["Link"] = data1[2].replace("\n", "").replace(" ","")
                else:
                    dict["Link"] = ""

                # get Tag 
                tag = data1[0].replace("-","").replace(" ","").replace(".","")
                tag = tag.lower()
                dict["Tag"] = "c"+ tag[0].upper() + tag[1:]

                if len(data1) >=4:
                    dict["Image"] = data1[3].replace("\n", "").replace(" ","")

                    if down_image:
                        __download_image(dict["Image"] , FOLDER)
                else:
                    dict["Image"] = IMAGE_LINK_DEFAULT 

                dict["Group"] = GROUP_NAME[group]
                list_dict.append(dict)
            
    with open("feed1.json", "w") as json_file:
        json.dump(list_dict, json_file)
    return

if __name__ == "__main__" :
    __excute(down_image = False)
