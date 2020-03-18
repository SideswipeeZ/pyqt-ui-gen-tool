	def __init__(self, parent=None):
		super(MyWindow, self).__init__(parent)
		#File Interface File goes here
		file_interface = os.path.join("PATH_HERE")
		self.main_widget = QtCompat.loadUi(file_interface)
		self.setCentralWidget(self.main_widget)
		#Set Window Title Here
		self.setWindowTitle("TITLE_HERE")

