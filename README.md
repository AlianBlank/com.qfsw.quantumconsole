# Quantum Console

Quantum Console 是一个拥有许多功能及容易使用的游戏命令控制台。只要在程序里输入[Command],您就可以在命令控制台另加特制的命令及游戏作弊码！

该库主要服务于 `https://github.com/AlianBlank/GameFrameX` 作为子库使用。


# 使用方式(三种方式)
1. 直接在 `manifest.json` 文件中添加以下内容
   ```json
      {"com.qfsw.quantumconsole": "https://github.com/AlianBlank/com.qfsw.quantumconsole.git"}
    ```
2. 在Unity 的`Packages Manager` 中使用`Git URL` 的方式添加库,地址为：https://github.com/AlianBlank/com.qfsw.quantumconsole.git

3. 直接下载仓库放置到Unity 项目的`Packages` 目录下。会自动加载识别

# 改动功能

1. 增加 `Packages` 的支持

# 当前版本 `2.6.3`

# 插件地址

https://assetstore.unity.com/packages/tools/utilities/quantum-console-211046

# 使用文档

https://www.qfsw.co.uk/docs/QC/

# 以下为原内容

使用

包括但不限于:

- 灵活的 QA 工具

- 软件开发测试作弊码

- 调试协助

- 游戏中的作弊码

- 适应任何项目


命令功能:

- 强类型和弱类型命令

- 命令重载以及缺省参数

- 通用命令

- 异步命令

- 兼容 functions, properties, fields 和 delegates

- 命令黑/白名单

- 方便使用

- 完整 C# 源代码


命令控制台功能:

- 显示 Debug.Log 消息

- 高度可定制

- 自定义主题系统

- 命令建议和自动完成

- 兼容 Text Mesh Pro


内置命令例子:

- call-static/call-instance: 应用任何C#函数属性

- man: 显示指定命令的用户手册

- exec: 运行时编译并执行 C# 源代码

- #define: 定义并创建用户宏

- instantiate: 实例对象的副本

- destroy: 删除对象

- get-object-info: 显示对象 transform 和 component 参数