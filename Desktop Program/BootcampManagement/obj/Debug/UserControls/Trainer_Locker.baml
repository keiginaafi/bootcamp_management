   M S B A M L   `   `   `  ����M  IBootcampManagement, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullQ-clr-namespace:BootcampManagement.UserControlsBootcampManagement.UserControls  5      4    .BootcampManagement.UserControls.Trainer_Locker   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?local-clr-namespace:BootcampManagement.UserControls     5      V RMaterialDesignThemes.Wpf, Version=2.5.1.1345, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5
      � $��0,25,0,0q�6   .+�5   
   �� -   5          ��Name$  Id_Tbox��5      $y�Hidden=�6#   69   �� 5   
   .+�5      �� $
��Wrap=�6   $��0,10,0,0q�6,   $��Manage Locker��6>   $��Center=�6S   $��25(�6p   $��Yu Gothic UI Bold)�6~   5      �� 5   
   $��200,80,200,0q�6   .+�5      �� $
��Wrap=�6   $��Name :��6,   $��12(�6:   $��Yu Gothic UI Light)�6H   �� 5      -   5         ��Name$ Name_Cmbbox��5      $
��Left=�6,   $��0,5,0,10q�6G   $	��Top=�6Y   $	��450��6q   $��Yu Gothic UI Light)�6}   �� 5      $
��Wrap=�6   $��Date :��6,   $��12(�6:   $��Yu Gothic UI Light)�6H   (  "System.Windows.Controls.DatePicker  5      -   5          Name$ Date_Dpc��5      $
��Left=�6+   $��0,5,0,0q�6F   $	��Top=�6W   $	��450��6o   $��Yu Gothic UI Light)�6{   �� 5      $
��Wrap=�6   $��
End Date :��6,   $��12(�6>   $��Yu Gothic UI Light)�6L     5      -   5        $ EndDate_Dpc��5      $
��Left=�6.   $��0,5,0,0q�6I   $	��Top=�6Z   $	��450��6r   $��Yu Gothic UI Light)�6~   �� 5       �� Orientation$ 
Horizontal=�6   $��
64,26,64,0q�62   $��33��6F   .+�5      �� -   5         ��Name$ 
Insert_Btn��5      $��Insert��6-   $	��Top=�6>   $
��Left=�6V   $��90��6q   $��30��6|   $��Yu Gothic UI Light)�6�   $��0,0,27,0q�6�   �� 5      -   5        $ 
Update_Btn��5      $��Update��6-   $	��Top=�6>   $
��Left=�6V   $��90��6q   $��30��6|   ���#FFCB48���#FFCB48$��Yu Gothic UI Light)�6�   $��0,0,27,0q�6�   �� 5      -   5        $ 
Delete_Btn��5      $��Delete��6-   $	��Top=�6>   $
��Left=�6V   $��90��6q   $��30��6|   ���#e74c3c���#e74c3c$��Yu Gothic UI Light)�6�   5      5      �� 5   
   $��	0,360,0,0q�6   .+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ Locker_DataGrid��5      $��Center=�60   $	��Top=�6M   $	��250��6e   $	��650��6r      AutoGenerateColumns .  $��	34,0,34,0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ No��6)   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 40 6L   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 65   �� *Id+6L     5       $
 Name��6)   $		 150 6P   
 67   �� *Name+6P     5!      $
 Date��6)   $	 * 6P   
 67   �� *Date+6P     5"      $ End Date��6)   $		 150 6W   
 6;   �� *	EndDate+6W      ColumnHeaderStyle 5$      �� 5%       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5&      ��  �� Property � �� �� Value$ Center=�6G   �� 5'       � ��
 �����67   �� 5(       � ��$ 30��63   �� 5)       � ��
 �   �67   5*      5,      5-      5.      5/      