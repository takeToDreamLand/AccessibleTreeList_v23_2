# 改进Accessibility能力的DevExpress.TreeList样例

> 基于DevExpress 23.2版本。

1. 改进UIA支持信息：对于树中的单元格，原本通过UIA无法获取单元格的识别信息；改进后识别信息会包含树节点的Value属性。但是并不能使原本无法侦测的控件变得可以侦测，因此这种方式并不能解决当前问题，只是作为一种可测试性的改进建议。详情查看样例Form1::InitializeComponent()方法。devExpress的UIA支持可以参考文档：《Accessibility Support》。
2. TreeList替换：验证对于被重复初始化、替换的TreeList控件是否仍可被UIA识别，结果是肯定的。因此这种方式不会引起UIA问题。详情查看样例Form1::OverwriteTree()方法。