import time
from os import path
from leanproAuto import WinAuto, Util
appPath = path.join(path.dirname(path.realpath(__file__)), "..\\AccessibleTreeList_v23_2\\bin\\Debug\\AccessibleTreeList_v23_2.exe")
fixedAppPath = path.join(path.dirname(path.realpath(__file__)), "..\\AccessibleTreeList_v23_2\\bin\\Debug\\AccessibleTreeList_v23_2_Fixed.exe")
modelPath = path.join(path.dirname(path.realpath(__file__)), "winform-sample.tmodel")
model = WinAuto.loadModel(modelPath)
def inspectControls():
    children = model.getTree("tree").findControls({"type": "TreeItem"})
    print(f"共有{len(children)}个树节点")
    model.getWindow("main").close()
    Util.delay(500)
    new_children = model.getTree("tree").findControls({"type": "TreeItem"})
    print(f"第二个窗口共有{len(new_children)}个树节点")
    if len(new_children) < len(children) and len(new_children) == 0:
        print("重现了问题")
    # model.getWindow("main").close()

def test_singleton_dialog():
    Util.launchProcess(appPath)
    if model.getWindow("About_DevExpress").exists():
        model.getButton("Close").click()
        Util.delay(500)
    inspectControls()
    Util.delay(1000)
if __name__ == '__main__':
    test_singleton_dialog()