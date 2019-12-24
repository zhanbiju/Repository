# 什么样的数据元素的处理适合用 IDictionary 这一类的数据模型来表达？
- IDictionary实现分为三个类别: 只读、固定大小、可变大小。 不能修改只读IDictionary对象。 固定大小IDictionary的对象不允许添加或删除元素, 但允许修改现有元素。 可变大小IDictionary对象允许添加、移除和修改元素。