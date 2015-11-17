namespace Namespace1.Library1
    module Module2 =
        let internal Version() =
            "Version 1.0"

namespace Namespace1.Library2
    module Module1 =
        let x = Namespace1.Library1.Module2.Version()