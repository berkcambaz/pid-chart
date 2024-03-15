import { Flex, useMantineTheme } from "@mantine/core";
import { Outlet } from "react-router-dom";

function MainLayout() {
  const theme = useMantineTheme();

  return (
    <Flex direction="column" p="xs" mx="auto" maw={theme.breakpoints.md} h="100vh">
      <Outlet />
    </Flex >
  )
}

export default MainLayout