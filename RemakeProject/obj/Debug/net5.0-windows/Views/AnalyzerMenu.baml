   M S B A M L   `   `   `  ����H  DRemakeProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:RemakeProjectRemakeProject  5   	   C&clr-namespace:RemakeProject.ViewModelsRemakeProject.ViewModels  5   	        RemakeProject.AnalyzerMenu   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:RemakeProject     5   	   5vm&clr-namespace:RemakeProject.ViewModels     5   	     � Title$  TextAnalyzer��5	   	   $	��350��5
   	   $	��600��5   	   $	��350��5   	   $	��600��5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      *  $RemakeProject.ViewModels.TextAnalyze  5   
   .��5      �  � ShowGridLines$ False��6    � ColumnDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      �� 5      $
��0.5* �6   �� 5      $��0.15* �6    � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      �� 5      $��0.35* �6   ��5!   
   �� 5"       �� Color$ #D3CCE3��6   .+�5%   
   �� $��2��6   $��Center=�5&      $��Center=�5'      �� 5(      .�6   .�5)      �� ��6   �� *CurrentUser+ �� Mode$ OneWay=� �� StringFormat$ 	User: {0}��5*      5+      �� 5,   
   -   5        	 ��Name$	 textBox��5,         InputBoxStyle#���   5-      ��5.      �� *Text+
 �� UpdateSourceTrigger$
 PropertyChanged=��� 50   
   -   5         ��Name$ Vowels��50      $��	20,15,0,0q�51        CountSymbolsStyle#���  52      ��53      �� *Vowels+$ OneWay=�$ Vowels: {0}���� 55   
   -   5        $ 
Consonants��55      $��	20,45,0,0q�56      #���  58      ��57      �� *
Consonants+$ OneWay=�$ Consonants: {0}��58      �� 5:   
   -   5        $ Numbers��5:      $��	20,75,0,0q�5;      #���  5=      ��5<      �� *	Numbers+$ OneWay=�$ Numbers: {0}��5=      �� 5?   
   -   5        $ SpecialSymbols��5?      $��
20,105,0,0q�5@      #���  5B      ��5A      �� *SpecialSymbols+$ OneWay=�$ Symbols: {0}��5B      �� 5D   
   -   5         ��Name$ FileInputButton��5D        FileInputStyle#���  5F      ��5E      ��  �� Path$ 	FileInput�5F      �� 5H   
   -   5        $ LogoutButton��5H        LogoutButtonStyle#���  5J      ��5I      �� $ LogOut�5J      5K      5L      