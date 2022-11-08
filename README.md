# How to customize series border in WinForms Chart

This example demonstrates how to customize series border for chart in Windows Forms.

You can customize the border color and border width for chart series. The default value of the border color is black and border width is 1. You can also customize the specific series points border based on the point index.

The following code snippet demonstrates how to apply the border style to overall chart series points.

```
// Set border for to chart series.
series.Style.Border.Width = 3;
series.Style.Border.Color = Color.Red;
```

![Winforms Chart with border and fill](https://user-images.githubusercontent.com/53489303/200620164-d93a69b2-2939-4b65-a996-607c668c276a.png)

The following code snippet demonstrates how to apply the border style to specific points in chart series.

```
// Set border style to specific chart series.
series.Styles[1].Border.Width = 3;
series.Styles[1].Border.Color = Color.Red;
```

![Chart with fill and specific border](https://user-images.githubusercontent.com/53489303/200620212-e01ffee9-d70e-42f5-801a-350148c74f2f.png)

You can avoid the borders in series cells by setting the border’s color as “transparent” in series’ style as demonstrated in the following code snippet.

```
// Set the border color to transparent to avoid the borders for series. 
series.Style.Border.Color = Color.Transparent;
```

![Chart with fill and without border](https://user-images.githubusercontent.com/53489303/200620598-0ac19fba-10b8-44d0-979d-a62d157e5dc0.png)

KB article - [How to customize series border in WinForms Chart](https://www.syncfusion.com/kb/10149/how-to-customize-series-border-in-chart)
