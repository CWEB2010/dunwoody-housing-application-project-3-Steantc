   M S B A M L   `   `   `  ����L  HProject_Three_GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Project_Three_GUIProject_Three_GUI  5   	   '    !Project_Three_GUI.Resident_Search   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Project_Three_GUI     5   	     � Title$  Resident_Search��5   	    � WindowState$ 	Maximized=�6"    � WindowStyle$
 None=�6:   $��	Tw Cen MT)�6M   $��18(�6d   .��5	      ]� .+�5
   
   �� $
��auto��6   $��/Resources/sidebanner.png��6   $	��Top=�6B   $
��Left=�6Z   5      �� 5   
   $��Right=�6   .+�5      � .+�5      �� -   5        $
��auto��5      $
��auto��6&   $
��Left=�64   $��	10,10,0,0q�6O   
�������
���   �$
��Back��6�   $��22(�6�    J� RenderTransformOrigin$ 	0.5,0.504&�6�   ��6�   Z� 6�   �� 5      -   5        $
��auto��5      $
��auto��6&   $��Right=�64   $��10,10,10,10q�6P   
�������
���   �$��X��6�   $��44(�6�   $ 	0.5,0.504&�6�   ��6�   Z� 6�   5      �� 5       �� Orientation$ 
Horizontal=�6   $��	20, 0 0 0q�62   .+�5      �� $��Search by ID Number: ��6   �� 5      -   5         ��Name$ search_id_number��5      $	��200��65   $	��300��6D   $��10 0 0 0q�6S   6g   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ resident_grid��5         SelectionMode$ Single=�6.      AutoGenerateColumns .  $��0 15 0 0q�6a   .@�6�   >	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Name+  5      $
 	ID Number��6)    6<   �� *	ID_Number+  5      $
 Floor��6)    68   �� *Floor+  5      $
 Resident Type��6)    6@   �� *Resident_Type+5      5      5      5      