   M S B A M L   `   `   `  ����  Laba4.1    Laba5.Window1   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Assassin's Creed Database��5   	   $	��450��6+   $	��800��68   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5	      $��* �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   $��10q�6;   .+�5      �� -   5         ��Name$ SearchTextBox��5      $	��200��6-   $��0,0,10,0q�69   $��Center=�6K   �� 5      -   5         ��Name$ SearchButton��5      $��Search��6+   6<   5      �� 5   
   $��1��6   $ 
Horizontal=�6"   $��10q�6;   .+�5      �� -   5         ��Name$ PlatformComboBox��5      $	��200��61   $��0,0,10,0q�6=   $��Center=�6O   .@�5      �� .��6   Filter by Platform...66   5      �� 5      -   5        $ FilterButton��5      $��Filter��6+   6<   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ GamesDataGrid��5      $��2��6*   $��10q�67      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Title��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 64   �� *TITLE+  5      $	 Release Date��6%   
 6;   �� *REALESEDATE+  5      $	 	Platforms��6%   
 68   �� *	PLATFORMS+  5      $	 Rating��6%   
 65   �� *RATING+  5      $	 Description��6%   
 6:   �� *DESCRIPTIONn+5       5!      5"      