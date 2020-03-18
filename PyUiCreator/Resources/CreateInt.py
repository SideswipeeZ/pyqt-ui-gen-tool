#Create the UI Block
if isPanel == True:
    #Create Interface Python Panel
    def onCreateInterface():
        my_window = MyWindow()
        my_window.show()
        return my_window
elif isPanel == False:
    #Create Interface Shelf.
    try:
        my_window.close()
    except:
        pass
    my_window = MyWindow()
    my_window.resize(SizeX,SizeY)
    my_window.show() 
