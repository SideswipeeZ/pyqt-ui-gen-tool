'''
    This was Exported by PyQt-UI Generator (V0.1) Barebones Framework Variant
    Created for easy access to UI code for DCC apps (Houdini, Maya, Nuke) Tested
    Requires Manual Coding to Finish setup
    Coded by Bilal Malik (Sideswipe)
'''

import os, sys

#Folder Path Goes Here
sys.path.insert(0, ("PATH_GOES_HERE"))

#Checks Houdini Enviroment for the variable PYUI and loads the path from it.
#(lambda __g: [(sys.path.insert(0, str(ui_l)), None)[1] for __g['ui_l'] in [(hou.getenv('PYUI'))]][0])(globals())

from Qt import QtWidgets, QtCompat, QtGui, QtCore

class MyWindow(QtWidgets.QMainWindow):
	def __init__(self, parent=None):
		super(MyWindow, self).__init__(parent)
		file_interface = os.path.join("Path Here")
		self.main_widget = QtCompat.loadUi(file_interface)
		self.setCentralWidget(self.main_widget)
		self.setWindowTitle("Name here")
		
#Create UI Window
try:
	my_window.close()
except:
	pass
	
my_window = MyWindow()
my_window.resize(500,500)
my_window.show()