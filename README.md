﻿#**PrionLifeRPG 开发记录**


Athor:&#8195;TheNO.5

标签： Unity Game Develop Note

----------
###未完成的功能

**第一界面**

	  - 分享、评价等调用移动平台API的触发事件的实现
	 
 
 &emsp;
 
 &emsp;
 
 &emsp;
 
 &emsp;

 ----------
**DATE: &emsp;2016.02.24** 

        TODO：可视化XML转SQLiteDB工具 &　增加所有角色显示

 ----------
**DATE: &emsp;2016.02.23**

 1. 编写XML转SQLiteDatabase脚本
 2. 完善SQLite数据库文件
 3. 建立SQLDB读取接口，并加入加载数据方式选择（XML || SQLDB）

        已实现功能：
        
        根据名字把单个角色信息从SQLDB中读取出来，建立数据原型，并将其显示在屏幕上。
 
 ----------
**DATE: &emsp;2016.02.22**

1. 增加Mono.Data.Sqlite、sqlite3、System.Data三个DLL
2. 增加Navicat 破解工具
 
 ----------
**DATE: &emsp;2016.02.20**

 1. 添加角色状态属性
 2. XML中增加医生和狱警数据
 
----------
 **DATE: &emsp;2016.02.21**
 
 
 根据PureMVC框架原理对角色显示代码进行优化
 
 ----------
**DATE: &emsp;2016.02.20**


 4. 制作两个prefab（腿在身体上层渲染 & 腿在身体下层渲染)，挂载初始化人物图片脚本
 5. 编写XML文本，已加入四个人物信息
 6. 编写XML读取工具
 7. 编写名为CommonDATA的static类，声明一Directionary（只读）用来存储从XML读取的人物信息
 8. 编写CharactorProxy，并提供关于角色操作的接口

**测试：**

	把xml中所列所有角色显示到屏幕上 
	
	
----------
**DATE: &emsp;2016.02.19**

**人物系统** 角色渲染的初始化

#实现思路一(采用)：

1. 编写Excel 映射 XML（包含角色名称、所用Prefab类型及各肢体部分所用Sprite名称）
2. 制作Prefab
3. 读取XML各角色信息，赋值给Prefab并加载渲染

#实现思路二(未采用)：

组装各角色肢体并依次制作Prefab

----------

**DATE: &emsp;2016.01.28**

搭建第一界面UI




 
