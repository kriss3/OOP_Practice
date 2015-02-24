Scenario

A company is building a new software system that is intended to help customers build a custom pair of glasses for purchase via a web site (Glasses configurator tool).
Initially, the design calls for a system that enables users to create spectacles or sunglasses but only with accurate combinations of options. 
Accordingly, you have been asked to design and build a Glasses Configuration component that enforces the correct selection of values.

Glasses
Glasses are always comprised of two component parts:
1.	The Lenses
2.	The Frame

Individual lenses can be described by their:
 - Manufacturer
 - Height
 - Width
 - Thickness
 - Lens Area
 - Magnification
 - Tints
 - Colour

 Frames can be described by their:
 - Colour
 - Manufacturer
 - Maximum Lens Thickness
 - Minimum Lens Thickness

Rules
Additionally, the project team has identified some important rules that must be incorporated into the design:
 - Measurements for lenses can be expressed in either millimeters (metric) or inches (imperial).
 - Lenses can be described by their shape, e.g. square, round, octagonal etc.
 - Lenses can have colours.
 - Some lenses can have tints but a tinted lens cannot have a colour.
 - Sunglasses have no magnification.
 - A lens cannot be higher than it is wide.
 - The following colours are available for lenses and frames:
   - Red
   - Blue
   - Yellow
   - Black
At the moment, the following tints are available
   - Pink
   - Purple
   - Rose
At the moment lenses are made by the following Manufacturers:
   - Bloggs & Son.
   - Tony & Co.
   - Generic
At the moment frames are manufactured by the following Manufacturers:
   - Bloggs & Son
   - GlobalHyperVarioOptometrics
   - Generic

Other Rules:
1.A frame with a specified (non-generic) manufacturer can only be matched with lenses made by the same manufacturer.
2.Frames can only contain lenses of the appropriate thickness.
