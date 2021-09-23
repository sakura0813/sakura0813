import xlrd
import random
import tkinter as tk

workbook = xlrd.open_workbook(r"D:\All About Programming\Code\Python code\clone\Python-100-Days\lianxi\name.xls")  # 读取表格
Data_sheet = workbook.sheets()[9]  # 读取sheet1
name_list = Data_sheet.col_values(0)  # 读取第一列
print(name_list)
data = set()  # 一个空set保存选过的同学

root = tk.Tk()
root.title("点名册")
root.geometry('500x400')

global var
var = tk.StringVar()
on_strat = False

l = tk.Label(root, textvariable=var, font=('楷书', 100), width=15, height=2)
l.pack()


def start():
    try:
        rdata = random.choice(name_list)
        if on_strat == False:
            name_list.remove(rdata)
            # print(rdata)
            if rdata not in data:
                var.set(rdata)
                data.add(rdata)
        if len(name_list) == 0:
            var.set("-----所有同学已经遍历完-------")
    except ValueError as e:
        var.set("-----所有同学已经遍历完-------")


B = tk.Button(root, text="start", command=start)
B.pack()




if __name__ == "__main__":
    root.mainloop()

