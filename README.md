# NumberDrawing

>[!warning]
>
> **!WARNING! 此项目仅为我这个菜鸡新手的练习作，只是在初初初初学 WPF，代码没有参考意义。**

## 简介
本软件为一款抽号软件，当点击开始抽号时，结果区会有滚动的数字以增加趣味性。再次点击停止抽号按钮，数字停止滚动，抽出一个幸运数字。

## 图片
![image](https://github.com/user-attachments/assets/c07c5704-24b5-420e-95b1-cb06813f69f0)
![image](https://github.com/user-attachments/assets/b93da8d2-984a-4db9-b9bf-01ec8972f0bd)
![image](https://github.com/user-attachments/assets/2b919c5c-2a2b-42e7-b271-2081aab4c0c3)

## 使用
### 先决要求
- 安装 [.NET 8.0 桌面运行时](https://dotnet.microsoft.com/zh-cn/download/dotnet/thank-you/runtime-desktop-8.0.8-windows-x64-installer)
- 系统架构为 x64
- 推荐为 Windows 10 及以上系统，Windows 7 未经测试
- 不支持除 Windows 以外任何系统
### 使用预构建版本
1. 前往 [Releases](https://github.com/LiuYan-xwx/NumberDrawing/releases) 界面找到最新版本，从 Assets 中下载软件。
2. 双击打开软件即可。
### 从源码编译
1. 克隆仓库到本地
2. 使用 Visual Studio 打开解决方案
3. 点击`生成`→`发布选定内容`，然后点击发布。生成完成后可在目标位置找到软件。

## 开发
本软件基于 .NET 8.0 开发，以 C# 作为编程语言，使用了 WPF 为框架，尝试使用了 [MVVM](https://learn.microsoft.com/zh-cn/dotnet/architecture/maui/mvvm) 架构开发（初学，尝试）。
使用了 [Microsoft Visual Studio 2022](https://visualstudio.microsoft.com/zh-hans/) 为 IDE 开发。

## 使用的第三方库
[iNKORE-NET/UI.WPF.Modern](https://github.com/iNKORE-NET/UI.WPF.Modern) (UI)

## License
本软件以 MIT 协议开源。
