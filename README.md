# 改进Accessibility能力的DevExpress.TreeList样例

> 基于DevExpress 23.2版本。

样例中会陆续打开两次对话框，该对话框是单例模式实现的，内部有一个简单的树控件。
第二次打开的对话框内的树是无法被UIA识别的。

## 测试
使用CukeTest运行test目录下的测试脚本，可以重现错误。